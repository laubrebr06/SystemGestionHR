using SystemGestionHR.Data.DTO;
using SystemGestionHR.Data.Models;
using SystemGestionHR.Services.Interfaces;
using SystemGestionHR.ValueObjects;

namespace SystemGestionHR.Services.UseCases
{
    public class SoumettreDemandeDeCongeUseCase
    {
        // Aquí simularíamos un repositorio real inyectado
        private readonly List<DemandeDeCongeDTO> _repositorySimule = new();
        private readonly IDemandeDeCongeService _repositoryDemandeDeCongeService;

        public SoumettreDemandeDeCongeUseCase(IDemandeDeCongeService repositoryDemandeDeCongeService)
        {
            _repositoryDemandeDeCongeService = repositoryDemandeDeCongeService;
        }

        public DemandeDeCongeDTO Executer(int demandeDeCongeId,int employeId, int typeCongeId, bool? status, DateTime dateDebut, DateTime dateFin, string? type, string? employeNom, string? commentaireEmploye)
        {
            try
            {
                var periode = new PeriodeConge(dateDebut, dateFin);

                DemandeDeCongeDTO demande = new DemandeDeCongeDTO();
                demande.DemandeDeCongeId = demandeDeCongeId;
                demande.EmployeId = employeId;
                demande.TypeCongeId = typeCongeId;
                demande.Status = status;
                demande.DateDebut = periode.DateDebut;
                demande.DateFin = periode.DateFin;
                demande.CommentaireEmploye = commentaireEmploye;
                demande.NomComplet = employeNom;
                demande.TypeConge = type;

      
                _repositoryDemandeDeCongeService.SoumettreDemandeDeConge(demande);

                return demande;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }
    }
}
