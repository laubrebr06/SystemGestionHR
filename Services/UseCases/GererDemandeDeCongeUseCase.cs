using SystemGestionHR.Data.Interfaces;
using SystemGestionHR.Services.Interfaces;

namespace SystemGestionHR.Services.UseCases
{
    public class GererDemandeDeCongeUseCase
    {
        private readonly IDemandeDeCongeService _repositoryDemandeDeCongeService;

        public GererDemandeDeCongeUseCase(IDemandeDeCongeService repositoryDemandeDeCongeService)
        {
            _repositoryDemandeDeCongeService = repositoryDemandeDeCongeService;
        }

        public bool Approuver(int id, string? commentaire)
        {
            var demande = _repositoryDemandeDeCongeService.ObtenirDemandeDeCongeParId(id);
            
            if (demande == null) return false;

           var approuver = _repositoryDemandeDeCongeService.ApprouverDemandeDeConge(id, commentaire);

            return approuver;
        }

        public bool Rejeter(int id, string? commentaire)
        {
            var demande = _repositoryDemandeDeCongeService.ObtenirDemandeDeCongeParId(id);
            
            if (demande == null) return false;
            demande.CommentaireManager = commentaire;

            var approuver = _repositoryDemandeDeCongeService.RejeterDemandeDeConge(id,commentaire);

            return approuver;
        }
    }
}
