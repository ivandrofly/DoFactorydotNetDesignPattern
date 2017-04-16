namespace MVC
{
    class StudentController
    {
        // model
        private Student _studentModel;

        // TODO: change to event pattern.
        private StudentView _studentView;

        public StudentController(Student studentModel, StudentView studentView)
        {
            _studentModel = studentModel;
            _studentView = studentView;
        }

        public void SetStudentName(string name)
        {
            _studentModel.Name = name;
        }

        // not in real app this is supposed to recive a ID which the student will be identified by
        public string GetStudentName() => _studentModel.Name;

        public void SetStudentRollNo(int rollNo)
        {
            _studentModel.RollNo = rollNo;
        }

        public int GetStudentRollNo() => _studentModel.RollNo;

        public void UpdateView()
        {
            _studentView.PrintStudnetDetails(_studentModel.Name, _studentModel.RollNo);
        }
    }
}
