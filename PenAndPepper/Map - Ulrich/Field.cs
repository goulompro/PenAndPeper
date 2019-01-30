using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PenAndPepper
{
    public class Field
    {
        public Field()
        {
            isVisible = false;
        }
        private FieldTyp incident;

        public FieldTyp Incident
        {
            get { return incident; }
            set { incident = value; }
        }

        private bool isVisible;

        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }
        public enum FieldTyp
        {
            forrest,
            plains,
            mountain,
            town,
            lake
        }
    }   
}
