using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_SA.Model
{
    public  class LinkedList<T>
    {
        public Item<T> Head { get; private set; }// стартовый  элемнт
        public Item <T> Tail { get; private set; } // последний  элемент
        public  int Count { get; private set; } // кол-во  элементов


        public  LinkedList() // конструктор  по умолчанию
        {
            Head = null; // в начале наш список  пустой 
            Tail = null; // хвост  пустой 
            Count = 0; // колл-во  элементов  0 
        }
       
        public  LinkedList( T  data ) // перегруженный констуктор
                                      // если хотим  создать  лист  и  передать  в него элемент
        {
            SetHeadAndTail(data); // вынесли  в отдельный  метод  , что  бы использовать 
            // два  раза
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data); // создали элемент 
            Head = item; // он  голова 
            Tail = item; // он  же и  хвост 
            Count = 1; // он  один в  списке  
        }

        public  void Add ( T data) // добавление  элимента 
        {
            if ( Tail != null )
            {
                var item = new Item<T>(data); // создали элемент 
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data); // если хвоста нет  
                // то делаем  как   в  public  LinkedList( T  data )
                // метод  использовали второй раз 
            }

        }

      
    }
}
