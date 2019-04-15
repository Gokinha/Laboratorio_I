using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sugestao_VO
{
    public class ResponsavelVO
    {
        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesResponsavel.ResourcesResponsavel), ErrorMessage = "Campanha_idUsuario_Required")]
        [Display(Name = "Campanha_idUsuario", ResourceType = typeof(Sugestao_VO.Resources.ResourcesResponsavel.ResourcesResponsavel))]
        public int idUsuario { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesResponsavel.ResourcesResponsavel), ErrorMessage = "Campanha_idCampanha_Required")]
        [Display(Name = "Campanha_idCampanha", ResourceType = typeof(Sugestao_VO.Resources.ResourcesResponsavel.ResourcesResponsavel))]
        public int idCampanha { get; set; }
    }
}
}
