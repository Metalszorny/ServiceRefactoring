using App.Model;

namespace App.Interfaces
{
    public interface ICompanyRepository
    {
        Company GetById(int id);
    }
}
