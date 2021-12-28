using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManager.repository
{
    public interface CrudRepository<T>
    {
        void Add(T entity);
        void delete(int invoiceId);
        List<T> getAll();
    }
}
