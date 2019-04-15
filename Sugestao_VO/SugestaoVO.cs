using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sugestao_VO
{
    public class SugestaoVO
    {
        [Key]
        [Display]
        public int idSugestao { get; set; }

        [Key]
        [Display(Name = "Sugestao_idUsuario", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao))]
        public int idUsuario { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao), ErrorMessage = "Sugestao_what_Required")]
        [Display(Name = "Sugestao_what", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao))]
        public string what { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao), ErrorMessage = "Sugestao_why_Required")]
        [Display(Name = "Sugestao_why", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao))]
        public string why { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao), ErrorMessage = "Sugestao_where_Required")]
        [Display(Name = "Sugestao_where", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao))]
        public string where { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao), ErrorMessage = "Sugestao_when_Required")]
        [Display(Name = "Sugestao_when", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao))]
        public string when { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao), ErrorMessage = "Sugestao_who_Required")]
        [Display(Name = "Sugestao_who", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao))]
        public string who { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao), ErrorMessage = "Sugestao_how_Required")]
        [Display(Name = "Sugestao_how", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao))]
        public string how { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao), ErrorMessage = "Sugestao_howmutch_Required")]
        [Display(Name = "Sugestao_howmutch", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao))]
        public decimal howmutch { get; set; }

        [Display(Name = "Sugestao_vencedor", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSugestao.ResourcesSugestao))]
        public bool vencedor { get; set; }
    }
}
