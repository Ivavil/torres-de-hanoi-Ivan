using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        private int size;
        private int top;
        private List<Disco> elementos;
        private String name;
        public int Size {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public int Top {
            get
            {
                return this.top;
            }
            set
            {
                this.top = value;
            }
        }
        public List<Disco> Elementos {
            get
            {
                return this.elementos;
            }
            set
            {
                this.elementos = value;
            }
        }

        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Pila(String name)
        {
            this.size = 0;
            this.top = 0;
            this.elementos = new List<Disco>();
            this.name = name;
        }
   
        public Pila(int size, int top, List<Disco> elementos, String name)
        {
            this.size = size;
            this.top = top;
            this.elementos = elementos;
            this.name = name;
        }

        public void push(Disco d)
        {
            this.elementos.Add(d);
            this.size++;
            this.top = d.Valor;
            

        }

        public Disco pop()
        {
            if(this.size > 0) {
                this.elementos.RemoveAt(this.size - 1);
                this.size--;
                if(this.size > 0) {
                    this.top = this.elementos[this.size - 1].Valor;
                } else if (this.size == 0)
                {
                    this.top = 0;
                }
                
                
            }
            return null;
        }                

        public bool isEmpty()
        {
            if(this.elementos.Count == 0) { return true; }
            return false;
        }

    }
}
