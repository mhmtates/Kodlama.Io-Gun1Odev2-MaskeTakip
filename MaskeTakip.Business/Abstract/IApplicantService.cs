using MaskeTakip.Entities.Concrete;

namespace MaskeTakip.Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Citizen citizen);


        List<Citizen> GetList();


        bool CheckCitizenOrNot(Citizen citizen);
        

    }
}
