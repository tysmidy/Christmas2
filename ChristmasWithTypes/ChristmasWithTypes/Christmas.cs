using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //Done Make the Height property nullable

        //done Make the property, "Day", type enum
        public enum Day { Monday, Tuesday , Wends , Thursday , Friday , Saturday , Sunday };

    }
}
