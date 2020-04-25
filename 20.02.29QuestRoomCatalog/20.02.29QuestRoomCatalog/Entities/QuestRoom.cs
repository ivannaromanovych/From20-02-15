using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _20._02._29QuestRoomCatalog.Entities
{
    [Table("tblQuestRoom")]
    public class QuestRoom
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(200)]
        public string Description { get; set; }
        [Required]
        public int Time { get; set; }
        [Required]
        public int ParticipantsMin { get; set; }        
        [Required]
        public int ParticipantMax { get; set; }
        [Required]
        public int MinAge { get; set; }
        [Required, Phone]
        public int PhoneNumber { get; set; }
        [Required, EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public int FearLevel { get; set; }
        [Required]
        public int DifficultyLevel { get; set; }
        [Required]
        public string Logo { get; set; }
        [Required]
        public ICollection<string> Photos { get; set; }
    }
}