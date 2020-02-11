using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Base
{
    //need to be public to call them in the gameclient
    public class Component
    {
        public string ID { get; set; }
        public bool Enabled { get; set; }

        public Component()
        {
            ID = GetType().Name + Guid.NewGuid();
            Enabled = true;
        }


        public virtual void intialize() { }
        public virtual void intialized() { }
        public virtual void Update() { }

        public event ObjectIDHandler OnDestroy;

        public virtual void Destroy()
        {
            if (OnDestroy != null)
                OnDestroy(ID);
        }

    }
}
