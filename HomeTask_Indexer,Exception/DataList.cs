using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_Indexer_Exception
{
    public class DataList <T> where T : BaseEntity
    {
        private T[] _datas;

        public DataList()
        {
            _datas = new T[0];
        }


        public void Add(T item)
        {
            Array.Resize(ref _datas,_datas.Length + 1);
            _datas[_datas.Length - 1] = item;
        }

    

        public T[] GetById(int id)
        {
           return _datas.Where(m => m.Id == id).ToArray();
        }

        public T[] Delete(int id)
        {
            return _datas.Where(m =>m.Id == id).ToArray();
        }
       
    }
}
