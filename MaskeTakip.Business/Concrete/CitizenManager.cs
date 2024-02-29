using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;

namespace MaskeTakip.Business.Concrete
{
    public class CitizenManager:IApplicantService
    {
        public void ApplyForMask(Citizen citizen)
        {

        }

        public List<Citizen> GetList()
        {
            return null;
        }

        public bool CheckCitizenOrNot(Citizen citizen)
        {
            return true;
        }

            
    }
}
