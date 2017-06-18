using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BAL
{
    public class StundetBAL
    {
        Student_DAL sdobj = new Student_DAL();
        public StundetBAL() { }
        

        public int insert(int sno,string firstname , string lastname ,int age)
        {
           
            try
            {
              return  sdobj.Insert(sno, firstname, lastname, age);
            }
            catch
            {
                throw;
            }
            finally
            {
                sdobj = null;
            }
        }

        public int Update(int sno, string firstname, string lastname, int age)
        {
            
            try
            {
                return sdobj.update(sno, firstname, lastname, age);
            }
            catch
            {
                throw;
            }
            finally
            {
                sdobj = null;
            }
        }

        public int Delete(int Sno)
        {
            try
            {
                return sdobj.delete(Sno);
            }
            catch
            {
                throw;
            }
            finally
            {
                sdobj = null;
            }
           
        }

        public DataTable Load()
        {
            try
            {
                return sdobj.Load();
            }
            catch
            {
                throw;
            }
            finally
            {
                sdobj = null;
            }
        }


    }
}
