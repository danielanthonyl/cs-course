using Microsoft.AspNetCore.Mvc;
using rpg.Dtos.Character;
using rpg.Services.CharacterService;

namespace rpg.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CharacterController : ControllerBase
  {
    private readonly ICharacterService _characterService;
    public CharacterController(ICharacterService characterService)
    {
      this._characterService = characterService;

    }

    [HttpGet]
    [Route("GetAll")]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> Get()
    {
      return Ok(await _characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> GetSingle(int id)
    {
      return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> PostChar(AddCharacterDTO newCharacter)
    {
      return Ok(await _characterService.AddCharacter(newCharacter));
    }
  }
}

