using SystemGestionHR.Data.DTO;
using SystemGestionHR.Data.Models;
using SystemGestionHR.Mappers.Interfaces;
using SystemGestionHR.Data.Interfaces;
using SystemGestionHR.Services.Interfaces;

namespace SystemGestionHR.Services
{
    public class TypeCongeService : ITypeCongeService
    {
        private readonly ITypeCongeRepository _typeCongeRepository;
        private readonly ITypeCongeMapper _typeCongeMapper;
        public TypeCongeService(ITypeCongeRepository typeCongeRepository, ITypeCongeMapper typeCongeMapper)
        {
            _typeCongeRepository = typeCongeRepository;
            _typeCongeMapper = typeCongeMapper;
        }
        /// <summary>
        /// Soumettre type Conge
        /// </summary>
        /// <param name="typeConge"></param>
        /// <returns></returns>
        public TypeConge SoumettreTypeConge(TypeCongeDTO typeConge)
        {
            TypeConge typeCongeEntity = _typeCongeMapper.MapToTypeConge(typeConge);
            TypeConge addTypeConge = _typeCongeRepository.SoumettreTypeConge(typeCongeEntity);

            return addTypeConge;
        }

        /// <summary>
        /// Supprimer type Conge by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool SupprimerTypeConge(int id)
        {
            TypeConge? typeConge = _typeCongeRepository.ObtenirParId(id);
            if (typeConge == null)
            {
                return false;
            }
            _typeCongeRepository.SupprimerTypeConge(typeConge);
            return true;
        }

        /// <summary>
        /// Modifier type Conge data
        /// </summary>
        /// <param name="typeCongeId"></param>
        /// <param name="typeCongeDTO"></param>
        /// <returns></returns>
        public bool ModifierTypeConge(int vacationTypeId, TypeCongeDTO vacationTypeDTO)
        {
            TypeConge typeCongeEntity = _typeCongeMapper.MapToTypeConge(vacationTypeDTO);
            return _typeCongeRepository.ModifierTypeConge(vacationTypeId, typeCongeEntity);
        }

        /// <summary>
        /// Obtenir Tout types Conge
        /// </summary>
        /// <returns></returns>
        public List<TypeCongeDTO> ObtenirTout()
        {
            List<TypeCongeDTO> typesConge = new List<TypeCongeDTO>();
            typesConge = _typeCongeRepository.ObtenirTout().Select(x => _typeCongeMapper.MapToTypeCongeDTO(x)).ToList();

            return typesConge;
        }

        /// <summary>
        /// Obtenir type conge pour id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TypeCongeDTO? ObtenirParId(int id)
        {
            TypeConge? typeConge = _typeCongeRepository.ObtenirParId(id);
            if (typeConge != null)
            {
                TypeCongeDTO typeCongeDTO = _typeCongeMapper.MapToTypeCongeDTO(typeConge);
                return typeCongeDTO;
            }
            else
            {
                return null;

            }

        }

    }
}
