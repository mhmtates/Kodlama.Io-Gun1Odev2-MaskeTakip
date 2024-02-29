using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;
using MernisServiceReference;

namespace MaskeTakip.Business.Concrete
{
    public class CitizenManager : IApplicantService
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
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(citizen.NationalIdentity,citizen.FirstName,citizen.LastName,citizen.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;



        }
    }
}
