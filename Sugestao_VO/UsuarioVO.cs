using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sugestao_VO
{
    public class UsuarioVO
    {


        [Key]
        [Display(Name = "Usuario_idUsuario", ResourceType = typeof(Sugestao_VO.Resources.ResourcesUsuario.ResourcesUsuario))]
        public int idUsuario { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesUsuario.ResourcesUsuario), ErrorMessage = "Usuario_nome_Required")]
        [Display(Name = "Sugestao_nome", ResourceType = typeof(Sugestao_VO.Resources.ResourcesUsuario.ResourcesUsuario))]
        public string nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesUsuario.ResourcesUsuario), ErrorMessage = "Usuario_idSetor_Required")]
        [Display(Name = "Sugestao_idSetor", ResourceType = typeof(Sugestao_VO.Resources.ResourcesUsuario.ResourcesUsuario))]
        public int idSetor { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesUsuario.ResourcesUsuario), ErrorMessage = "Usuario_Senha_Required")]
        [Display(Name = "Sugestao_Senha", ResourceType = typeof(Sugestao_VO.Resources.ResourcesUsuario.ResourcesUsuario))]
        public string senha { get; set; }

        [Required(ErrorMessageResourceType = typeof(Sugestao_VO.Resources.ResourcesUsuario.ResourcesUsuario), ErrorMessage = "Usuario_cpf_Required")]
        [Display(Name = "Sugestao_cpf", ResourceType = typeof(Sugestao_VO.Resources.ResourcesUsuario.ResourcesUsuario))]
        public string cpf { get; set; }
    }
}
