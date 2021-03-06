﻿namespace TestNinja.Mocking
{
    class EmployeeStorage : IEmployeeStorage
    {
        private EmployeeContext _db;

        public EmployeeStorage()
        {
            _db = new EmployeeContext();
        }

        public void Delete(int id)
        {
            var employee = _db.Employees.Find(id);
            if (employee == null)
                return;
            _db.Employees.Remove(employee);
            _db.SaveChanges();
        }
    }
}
