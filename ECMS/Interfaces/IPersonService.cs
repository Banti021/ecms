using ECMS.DTO;

namespace ECMS.Interfaces;

public interface IPersonService
{
    Task<PersonDto> GetPersonByIdAsync(int id, CancellationToken token);
    Task<List<PersonDto>> GetAllPersonsAsync(CancellationToken token);
    Task<PersonDto> AddPersonAsync(PersonDto personDto);
    Task<PersonDto> UpdatePersonAsync(int id, PersonDto personDto);
    Task DeletePersonAsync(int id);
}