using System.Collections.Generic;
using System.Threading.Tasks;
using example.Dtos.Character;
using example.Models;

namespace example.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
         Task<ServiceResponse<GetCharacterDto>> UdpateCharacter(UpdateCharacterDto updateCharacter);
         Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}