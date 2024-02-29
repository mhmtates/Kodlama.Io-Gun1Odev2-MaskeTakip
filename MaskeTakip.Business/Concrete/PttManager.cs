using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;

namespace MaskeTakip.Business.Concrete
{
    public class PttManager
    {
        private readonly IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Citizen citizen)
        {

            if (_applicantService.CheckCitizenOrNot(citizen))
            {
                Console.WriteLine(citizen.FirstName + "için maske verildi.");
            }

        }
    }
}
