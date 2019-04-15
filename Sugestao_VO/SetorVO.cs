using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sugestao_VO
{
    public class SetorVO
    {
        [Key]
        public int idSetor { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesSetor.ResourcesSetor), ErrorMessage = "Setor_idUsuario_Required")]
        [Display(Name = "Setor_idUsuario", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSetor.ResourcesSetor))]
        public string nome { get; set; }

        [Display(Name = "Setor_descricao", ResourceType = typeof(Sugestao_VO.Resources.ResourcesSetor.ResourcesSetor))]
        public string descricao { get; set; }
    }
}
