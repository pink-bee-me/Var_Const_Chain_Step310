using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Const_Chain_Step310
{
    class Pet
    {
        public string PetId { get; set; }
        public string PetFamilyName { get; set; }
        public string OwnerName { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public string PetGender { get; set; }
        public string PetBreed { get; set; }
        public string PetAge { get; set; }
        public string NextAppointment { get; set; }
        public string ApptTime { get; set; }
        public List<Pet> Pets { get; set; }

        public Pet(string id) : this(id, "", "", "", "", "", "")
        {

        }

        public Pet(string petFamilyName, string petName) : this("", petFamilyName, "", petName, "", "", "")
        {

        }

        public Pet(string id, string petFamilyName, string petName) : this(id, petFamilyName, "", petName, "", "", "")
        {

        }

        public Pet(string id, string petFamilyName, string ownerName, string petName, string type, string breed, string petAge)
        {
            PetId = id;
            PetFamilyName = petFamilyName;
            OwnerName = ownerName;
            PetName = petName;
            PetType = type;
            PetBreed = breed;
            PetAge = petAge;
        }

  


    }
}