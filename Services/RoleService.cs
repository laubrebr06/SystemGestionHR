using SystemGestionHR.Mappers.Interfaces;
using SystemGestionHR.Data.DTO;
using SystemGestionHR.Data.Models;
using SystemGestionHR.Data.Interfaces;
using SystemGestionHR.Services.Interfaces;

namespace SystemGestionHR.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IRoleMapper _roleMapper;
        public RoleService(IRoleRepository roleRepository, IRoleMapper roleMapper)
        {
            _roleRepository = roleRepository;
            _roleMapper = roleMapper;
        }

        /// <summary>
        /// Obtenir Tout of roles DTO
        /// </summary>
        /// <returns></returns>
        public List<RoleDTO> ObtenirTout()
        {
            List<RoleDTO> roles = new List<RoleDTO>();
            roles = _roleRepository.ObtenirTout().Select(x => _roleMapper.MapToRoleDTO(x)).ToList();
            return roles;
        }

        /// <summary>
        ///Obtenir role DTO pour Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RoleDTO? ObtenirParId(int id)
        {
            Role? role = _roleRepository.ObtenirParId(id);
            if (role == null)
            {
                return null;
            }
            RoleDTO roleDTO = _roleMapper.MapToRoleDTO(role);
            return roleDTO;
        }



        /// <summary>
        /// Soumettre role to db
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public Role SoumettreRole(RoleDTO role)
        {
            Role roleEntity = _roleMapper.MapToRole(role);
            return _roleRepository.SoumettreRole(roleEntity);
        }

        /// <summary>
        /// Supprimerrole 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool SupprimerRole(int id)
        {
            Role? role = _roleRepository.ObtenirParId(id); ;
            if (role == null)
            {
                return false;
            }
            _roleRepository.SupprimerRole(role);
            return true;

        }
        /// <summary>
        /// Modifier role data 
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="roleDTO"></param>
        /// <returns></returns>
        public bool ModifierRole(int roleId, RoleDTO roleDTO)
        {
            Role roleEntity = _roleMapper.MapToRole(roleDTO);
            return _roleRepository.ModifierRole(roleId, roleEntity);
        }
    }
}
