namespace ObjectListViewSample
{
    enum Gender
    {
        Unknown = 0, Male = 1, Female = 2
    }

    public enum EmployeeState
    {
        Working = 0,
        Vacation = 1
    }

    class Employee : ObservableObject
    {

        private string _job;
        public string Job
        {
            get => _job;
            set => SetField(ref _job, value);
        }

        private Gender _gender = Gender.Unknown;
        public Gender Gender
        {
            get => _gender;
            set => SetField(ref _gender, value);
        }

        private string _photo;
        public string Photo
        {
            get => _photo;
            set => SetField(ref _photo, value);
        }

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                SetField(ref _firstName, value);
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                SetField(ref _lastName, value);
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string FullName => $"{FirstName} {LastName}".Trim();

        private int _kpi = 0;
        public int Kpi
        {
            get => _kpi;
            set => SetField(ref _kpi, value);
        }

        private EmployeeState _state = EmployeeState.Working;
        public EmployeeState State
        {
            get => _state;
            set => SetField(ref _state, value);
        } 

        public override string ToString()
        {
            return FullName;
        }
    }
}
