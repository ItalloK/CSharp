﻿namespace ProjetoAPI.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        List<Employee> Get();
    }
}