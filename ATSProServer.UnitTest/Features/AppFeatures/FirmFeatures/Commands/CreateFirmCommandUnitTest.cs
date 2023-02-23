using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities;
using Moq;
using Shouldly;

namespace ATSProServer.UnitTest.Features.AppFeatures.FirmFeatures.Commands;

public class CreateFirmCommandUnitTest
{ 
    public readonly Mock<IFirmService> _firmService;

    public CreateFirmCommandUnitTest()
    {
        _firmService = new ();
    }

    [Fact]
    public async Task FirmShouldBeNull()
    {
        Firm firm = (await _firmService.Object.GetFirmByName("Test Company"))!;
        firm.ShouldBeNull();
    }
}

