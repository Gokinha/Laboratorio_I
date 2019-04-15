using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sugestao_VO
{
    public class CampanhaVO
    {
        [Key]
        [Display(Name = "Campanha_idCampanha", ResourceType = typeof(Sugestao_VO.Resources.ResourcesCampanha.ResourcesCampanha))]
        public int idCampanha { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesCampanha.ResourcesCampanha), ErrorMessage = "Campanha_descricao_Required")]
        [Display(Name = "Campanha_descricao", ResourceType = typeof(Sugestao_VO.Resources.ResourcesCampanha.ResourcesCampanha))]
        public string descricao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesCampanha.ResourcesCampanha), ErrorMessage = "Campanha_nome_Required")]
        [Display(Name = "Campanha_nome", ResourceType = typeof(Sugestao_VO.Resources.ResourcesCampanha.ResourcesCampanha))]
        public string nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesCampanha.ResourcesCampanha), ErrorMessage = "Campanha_dtInicial_Required")]
        [Display(Name = "Campanha_dtInicial", ResourceType = typeof(Sugestao_VO.Resources.ResourcesCampanha.ResourcesCampanha))]
        public DateTime dtInicial { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesCampanha.ResourcesCampanha), ErrorMessage = "Campanha_dtFinal_Required")]
        [Display(Name = "Campanha_dtFinal", ResourceType = typeof(Sugestao_VO.Resources.ResourcesCampanha.ResourcesCampanha))]
        public DateTime dtFinal { get; set; }
    }
}
