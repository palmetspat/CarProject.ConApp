using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Logic
{
    public class Section
    {
        #region properties
        public int MaxSpeed { get; set; }
        public int Length { get; set; }
        public Section? NextSection { get; set; }
        public Section? PreviousSection { get; set; }

        #endregion properties

        public Section(int speed, int length)
        {
            MaxSpeed = speed;
            Length = length;
        }

        public void AddAfterMe(Section section)
        {
            Section? tmp = NextSection;

            NextSection = section;

            section.NextSection = tmp;
        }

        public void AddBeforeMe(Section section)
        {
            PreviousSection = section;
        }
    }
}
