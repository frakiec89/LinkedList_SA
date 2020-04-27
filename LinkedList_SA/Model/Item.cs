using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_SA.Model
{

    /// <summary>
    /// Класс  элемент списка  
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T> //  Параметр  Т  - это обобщенеи  
        // тоесть  вмето Т   может  быть  любой тип данных  , например  int
    {
        private T data = default(T); // наши  данные  в  одном  элементе  списка
        public Item<T> Next { get; set; } // след. элемент  списка

        public T Data // свойство  даннные 
        {   get
            {
                return data; // получить данные 
            } 
            set // задать данные  
            {
                if (value != null) // не пустое значение 
                {
                    data = value;
                }
                else
                { throw new ArgumentException("Пустой  аргумент");  }// генерируем исключение
            }
        }

        public   Item (T data) // констурктор 
        {
            Data =data;
        }

        public override string ToString()// переопределяем  базовый  метод 
        {
            return Data.ToString(); 
        }
    }
}
