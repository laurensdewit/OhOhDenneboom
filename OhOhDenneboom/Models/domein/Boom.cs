using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace OhOhDenneboom
{
    public class Boom
    {
        private int Score;

        public Boom()
        {
            throw new System.NotImplementedException();
        }

        public int BoomId { get; set; }

        [Display(Name = "Kerstboom naam")]  //added
        [Required(ErrorMessage = "{0} is verplicht")] //added
        [StringLength(25, MinimumLength = 3, ErrorMessage = "{0} moet tussen 3 en 25 karakters lang zijn")]
        public string Naam
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void UpVote()
        {
            throw new System.NotImplementedException();
        }
    }
}
