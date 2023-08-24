using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace opgave_kørtøj.animal
{
    using System;

    // Test
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            using (SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\Tec\\source\\repos\\opgave kørtøj\\opgave kørtøj\\MakeSound\\cat (1).wav")) 
            {
                soundPlayer.Play();
            }
        }
    }
}
