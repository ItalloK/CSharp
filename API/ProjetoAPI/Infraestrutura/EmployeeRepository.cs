using ProjetoAPI.Model;

namespace ProjetoAPI.Infraestrutura
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly Conexao _context = new Conexao();

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> Get()
        {
            return _context.Employees.ToList();
        }
    }
}
