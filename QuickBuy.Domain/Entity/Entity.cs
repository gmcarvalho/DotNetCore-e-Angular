using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entity
{
    public abstract class Entity 
    {
        public List<string> _messagesValidation { get; set; }

        public List<string> MessageValidation {
            get { return _messagesValidation ?? (_messagesValidation = new List<string>()); }    
        }

        protected void ClearMessageValidation() {
            MessageValidation.Clear();
        }

        protected void AddMessage(string message) {
            MessageValidation.Add(message);
        }

        public abstract void Validate();

        protected bool IsValid {
            get { return MessageValidation.Any(); }
        }
    }
}
