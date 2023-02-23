using ATSProServer.Domain.AppEntities.Identity;

namespace ATSProServer.Domain.Roles;

public sealed class RoleList
{
    public static List<AppRole> GetStaticRoles()
    {
        List<AppRole> appRoles = new List<AppRole>
        {
            #region Car

            new AppRole(
            title: Car,
            code: CarCreateCode,
            name: CarCreateName),
            
            new AppRole(
            title: Car,
            code: CarUpdateCode,
            name: CarUpdateName),
             
            new AppRole(
            title: Car,
            code: CarRemoveCode,
            name: CarRemoveName),

             new AppRole(
            title: Car,
            code: CarReadCode,
            name: CarReadName),
            #endregion
        };
       
        return appRoles;

    }

    #region RoleTitleName
    public static string Car = "Araç Kayıt";
    #endregion

    #region RoleCodeAndNames
    public static string CarCreateCode = "Car.Create";
    public static string CarCreateName = "Araç Kaydetme";
    
    public static string CarUpdateCode = "Car.Update";
    public static string CarUpdateName = "Araç Güncelleme";

    public static string CarRemoveCode = "Car.Remove";
    public static string CarRemoveName = "Araç Silme";

    public static string CarReadCode = "Car.Read";
    public static string CarReadName = "Araç Görüntüleme";
    #endregion



}
