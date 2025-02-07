using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CryptoController : ControllerBase
{
    private const int Shift = 3; 

    [HttpPost("encrypt")]
    public IActionResult Encrypt([FromBody] string input)
    {
        string encrypted = new string(input.Select(c => (char)(c + Shift)).ToArray());
        return Ok(new { encrypted });
    }

    [HttpPost("decrypt")]
    public IActionResult Decrypt([FromBody] string input)
    {
        string decrypted = new string(input.Select(c => (char)(c - Shift)).ToArray());
        return Ok(new { decrypted });
    }

    
    [HttpGet("hello")]
    public IActionResult Hello()
    {
        return Ok(new { message = "Hej" });
    }
}
