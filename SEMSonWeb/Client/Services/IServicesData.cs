
namespace SEMSonWeb.Client.Services
{
    public interface IServicesData
    {
        event Action? Callab;
        string ActionCall { get; set; }
        string ActionModel { get; set; }
        SPClientUser SPClientUserX { get; set; }
        SPClientProfile SPClientProfileX { get; set; }
        SPClientClass SPClientClassX { get; set; }
        SPClientDep SPClientDepX { get; set; }
        SPClientPos SPClientPosX { get; set; }
        SPClientPre SPClientPreX { get; set; }
        SPHisAction SPHisActionX { get; set; }
        SPModelEquip SPModelEquipX { get; set; }
        SPModelSport SPModelSportX { get; set; }

        List<SPClientUser> SPClientUserList { get; set; }
        List<SPClientProfile> SPClientProfileList { get; set; }
        List<SPClientClass> SPClientClassList { get; set; }
        List<SPClientDep> SPClientDepList { get; set; }
        List<SPClientPos> SPClientPosList { get; set; }
        List<SPClientPre> SPClientPreList { get; set; }
        List<SPHisAction> SPHisActionList { get; set; }
        List<SPModelEquip> SPModelEquipList { get; set; }
        List<SPModelSport> SPModelSportList { get; set; }
        List<History> history { get; set; } 
        List<History> histories { get; set; } 

        Task GetDbSPClientUser();
        Task GetDbSPClientProfile();
        Task GetDbSPClientClass();
        Task GetDbSPClientDep();
        Task GetDbSPClientPos();
        Task GetDbSPClientPre();



        Task CreateDbSPClientUser(SPClientUser user);
        Task CreateDbSPClientClass(SPClientClass cla);
        Task CreateDbSPClientDep(SPClientDep dep);
        Task CreateDbSPClientPos(SPClientPos pos);
        Task CreateDbSPClientPre(SPClientPre pre);


        Task UpdateDbSPClientUser(SPClientUser user);
        Task UpdateDbSPClientClass(SPClientClass cla);
        Task UpdateDbSPClientDep(SPClientDep dep);
        Task UpdateDbSPClientPos(SPClientPos pos);
        Task UpdateDbSPClientPre(SPClientPre pre);


        Task DeleteDbSPClientUser(string idu, string idp);
        Task DeleteDbSPClientClass(string id);
        Task DeleteDbSPClientDep(string id);
        Task DeleteDbSPClientPos(string id);
        Task DeleteDbSPClientPre(string id);

        void ClearformUser();
        void ClearformSport();

        void EditMember(SPClientUser user);
        void EditEquip(SPModelEquip equip);

        Task GetDbSPModelEquip();
        Task GetDbSPModelSport();

        Task CreateDbSPModelEquip(SPModelEquip Equip);
        Task CreateDbSPModelSport(SPModelSport sport);

        Task UpdateDbSPModelSport(SPModelSport sport);
        Task UpdateDbSPModelEquip(SPModelEquip Equip);
        Task BorrowDbSPModelEquip(SPModelEquip Equip);
        Task ReturnDbSPModelEquip(SPModelEquip Equip);

        Task DeleteDbSPModelSport(string id);
        Task DeleteDbSPModelEquip(string id);

        Task GetDbSPHisAction();
        Task CreateDbSPHisAction(SPHisAction His);
        Task TurnDbSPHisAction(SPHisAction His);


    }
}
