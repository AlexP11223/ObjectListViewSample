using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace ObjectListViewSample
{
    public partial class Form2 : Form
    {
        private readonly List<Employee> _employees = new List<Employee>
        {
            new Employee
            {
                FirstName = "Alice",
                LastName = "Smith",
                Gender = Gender.Female,
                Job = "Accountant",
                Kpi = 4
            },
            new Employee
            {
                FirstName = "Bob",
                LastName = "Smith",
                Gender = Gender.Male,
                Job = "Manager",
                Kpi = 5
            },
            new Employee
            {
                FirstName = "Carol",
                LastName = "Smith",
                Gender = Gender.Female,
                Job = "Programmer",
                Kpi = 3
            },
            new Employee
            {
                FirstName = "James",
                LastName = "Smith",
                Gender = Gender.Male,
                Job = "Programmer",
                Kpi = 2
            },
            new Employee
            {
                FirstName = "Kate",
                LastName = "Green",
                Gender = Gender.Female,
                Job = "Manager",
                Kpi = 1
            },
            new Employee
            {
                FirstName = "Andy",
                LastName = "Brown",
                Gender = Gender.Male,
                Job = "Intern",
                Kpi = 0
            },
            new Employee
            {
                FirstName = "Bill",
                LastName = "Gates",
                Gender = Gender.Male,
                Job = "CEO",
                Photo = Program.AppDir + "bill.jpg",
                Kpi = 5,
                State = EmployeeState.Vacation
            },
        };

        private readonly TypedObjectListView<Employee> _tplstEmployees; // http://objectlistview.sourceforge.net/cs/recipes.html#isn-t-there-are-way-to-get-rid-of-all-the-casts-in-the-delegates
        
        public Form2()
        {
            InitializeComponent();

            _tplstEmployees = new TypedObjectListView<Employee>(lstEmployees);

            colFullName.ImageGetter = obj =>
            {
                var emp = (Employee) obj;
                
                // показывать иконку пола если нет фото
                if (String.IsNullOrEmpty(emp.Photo) || !File.Exists(emp.Photo))
                {
                    return (obj as Employee)?.Gender.ToString().ToLower();
                }

                // загрузить фото если еще не загружено
                if (!imglstPhotos.Images.ContainsKey(emp.Photo))
                {
                    imglstPhotos.Images.Add(emp.Photo, Bitmap.FromFile(emp.Photo));
                }

                return emp.Photo;
            };

            colFullName.Renderer = new DescribedTaskRenderer
            {
                ImageList = imglstPhotos,
                DescriptionAspectName = "Job",
                TitleFont = new Font(this.Font.FontFamily, 12, FontStyle.Bold),
                DescriptionFont = new Font(this.Font.FontFamily, 10),
                UseGdiTextRendering = true,
                ImageTextSpace = 8,
                TitleDescriptionSpace = 1
            };
            colFullName.CellPadding = new Rectangle(4, 2, 4, 2); // Put a little bit of space around the cell

            // group by the first last name letter
            colFullName.GroupKeyGetter = obj =>
            {
                var emp = (Employee) obj;
                return String.IsNullOrWhiteSpace(emp.LastName) ? "" : emp.LastName.Substring(0, 1);
            };

            colKpi.Renderer = new MultiImageRenderer("money", 5, 0, 6)
            {
                Spacing = -12 // overlap
            };

            colState.ImageGetter = obj => (obj as Employee)?.State.ToString().ToLower();
            colState.AspectToStringConverter = val =>
            {
                switch ((EmployeeState) val)
                {
                    case EmployeeState.Vacation:
                        return "On vacation";
                    default:
                        return val.ToString();
                }
            };

            colAction.AspectToStringConverter = val =>
            {
                switch ((EmployeeState) val)
                {
                    case EmployeeState.Working:
                        return "Take a vacation";
                    case EmployeeState.Vacation:
                        return "Return to work";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(val), val, null);
                }
            };
            lstEmployees.ButtonClick += (sender, e) =>
            {
                var emp = (Employee) e.Model;

                switch (emp.State)
                {
                    case EmployeeState.Working:
                        emp.State = EmployeeState.Vacation;
                        break;
                    case EmployeeState.Vacation:
                        emp.State = EmployeeState.Working;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(emp.State), emp.State, null);
                }
            };

            lstEmployees.SetObjects(_employees);

            cbbGender.DataSource = Enum.GetValues(typeof(Gender));

            UpdateControlsState();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var emp = new Employee();
            _employees.Add(emp);
            lstEmployees.AddObject(emp);

            lstEmployees.SelectedObject = _employees.Last();
            tboxFirstName.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var emp in _tplstEmployees.SelectedObjects)
            {
                _employees.Remove(emp);
            }
            lstEmployees.RemoveObjects(lstEmployees.SelectedObjects);

            UpdateControlsState();
        }

        private void UpdateControlsState()
        {
            pnlEditing.Enabled = lstEmployees.SelectedObjects.Count == 1;
            btnRemove.Enabled = lstEmployees.SelectedObjects.Count > 0;
        }

        private void UpdateEditingControls()
        {
            if (lstEmployees.SelectedObjects.Count != 1)
            {
                return;
            }

            var employee = _tplstEmployees.SelectedObject;

            tboxFirstName.Text = employee.FirstName;
            tboxLastName.Text = employee.LastName;
            cbbGender.SelectedItem = employee.Gender;
            tboxJob.Text = employee.Job;
            tboxPhoto.Text = employee.Photo;
            numKpi.Value = employee.Kpi;
        }

        private void RebuildFilters()
        {
            var filters = new List<IModelFilter>();

            if (chkFilterHighKpi.Checked)
            {
                filters.Add(new ModelFilter(obj => ((Employee) obj).Kpi > 3));
            }

            if (chkFilterVacation.Checked)
            {
                filters.Add(new ModelFilter(obj => ((Employee) obj).State == EmployeeState.Vacation));
            }

            if (!String.IsNullOrWhiteSpace(tboxFilter.Text))
            {
                filters.Add(TextMatchFilter.Contains(lstEmployees, tboxFilter.Text.Trim()));
            }

            // Use AdditionalFilter (instead of ModelFilter) since AdditionalFilter plays well with any
            // extra filtering the user might specify via the column header
            lstEmployees.AdditionalFilter = filters.Any() ? new CompositeAllFilter(filters) : null;
        }

        private void lstEmployees_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateControlsState();

            UpdateEditingControls();
        }

        private void tboxFirstName_TextChanged(object sender, EventArgs e)
        {
            _tplstEmployees.SelectedObject.FirstName = tboxFirstName.Text.Trim();
        }

        private void tboxLastName_TextChanged(object sender, EventArgs e)
        {
            _tplstEmployees.SelectedObject.LastName = tboxLastName.Text.Trim();
        }

        private void tboxJob_TextChanged(object sender, EventArgs e)
        {
            _tplstEmployees.SelectedObject.Job = tboxJob.Text.Trim();
        }

        private void cbbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tplstEmployees.SelectedObject.Gender = (Gender) cbbGender.SelectedItem;
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tboxPhoto.Text = dlg.FileName;
            }
        }

        private void tboxPhoto_TextChanged(object sender, EventArgs e)
        {
            string filePath = tboxPhoto.Text.Trim();
            if (String.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                _tplstEmployees.SelectedObject.Photo = null;
            }

            _tplstEmployees.SelectedObject.Photo = filePath;
        }

        private void numKpi_ValueChanged(object sender, EventArgs e)
        {
            _tplstEmployees.SelectedObject.Kpi = (int) numKpi.Value; 
        }

        private void tboxFilter_TextChanged(object sender, EventArgs e)
        {
            RebuildFilters();
        }

        private void chkFilterHighKpi_CheckedChanged(object sender, EventArgs e)
        {
            RebuildFilters();
        }

        private void chkFilterVacation_CheckedChanged(object sender, EventArgs e)
        {
            RebuildFilters();
        }

        private void chkGroup_CheckedChanged(object sender, EventArgs e)
        {
            lstEmployees.ShowGroups = chkGroup.Checked;
            if (lstEmployees.ShowGroups)
            {
                lstEmployees.BuildGroups();
            }
        }

        private void lstEmployees_FormatRow(object sender, FormatRowEventArgs e)
        {
            var emp = (Employee) e.Model;

            if (chkHighlightLowKpi.Checked)
            {
                if (emp.Kpi < 2)
                {
                    e.Item.BackColor = Color.OrangeRed;
                }
            }
        }

        private void chkHighlightLowKpi_CheckedChanged(object sender, EventArgs e)
        {
            lstEmployees.RefreshObjects(_employees);
        }
    }
}
