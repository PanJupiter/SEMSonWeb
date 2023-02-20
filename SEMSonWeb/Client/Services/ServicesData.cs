

using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace SEMSonWeb.Client.Services
{
    public class ServicesData : IServicesData
    {
        public event Action? Callab;
        public string ActionControl { get; set; } = "visible";
        public string ActionUser { get; set; } = "visible";
        public string ActionCall { get; set; } = "sign";
        public string ActionModel { get; set; } = "add";
        public string ActionPos { get; set; } = "one";
        public string DisplayMain { get; set; } = "visually-hidden";
        public string LoginID { get; set; } = string.Empty;
        public string LoginPassword { get; set; } = string.Empty;
        public SPClientUser SPClientUserX { get; set; } = new SPClientUser { LSPClientProfile = new SPClientProfile { LSPClientClass = new SPClientClass(), LSPClientDep = new SPClientDep(), LSPClientPos = new SPClientPos(), LSPClientPre = new SPClientPre() } };
        public SPClientProfile SPClientProfileX { get; set; } = new SPClientProfile { LSPClientPos = new SPClientPos() };
        public SPClientClass SPClientClassX { get; set; } = new SPClientClass();
        public SPClientDep SPClientDepX { get; set; } = new SPClientDep();
        public SPClientPos SPClientPosX { get; set; } = new SPClientPos();
        public SPClientPre SPClientPreX { get; set; } = new SPClientPre();
        public SPHisAction SPHisActionX { get; set; } = new SPHisAction();
        public SPModelEquip SPModelEquipX { get; set; } = new SPModelEquip{LSPModelSport = new SPModelSport()};
        public SPModelSport SPModelSportX { get; set; } = new SPModelSport();


        public List<SPClientUser> SPClientUserList { get; set; } = new List<SPClientUser>();
        public List<SPClientProfile> SPClientProfileList { get; set; } = new List<SPClientProfile>();
        public List<SPClientClass> SPClientClassList { get; set; } = new List<SPClientClass>();
        public List<SPClientDep> SPClientDepList { get; set; } = new List<SPClientDep>();
        public List<SPClientPos> SPClientPosList { get; set; } = new List<SPClientPos>();
        public List<SPClientPre> SPClientPreList { get; set; } = new List<SPClientPre>();
        public List<SPHisAction> SPHisActionList { get; set; } = new List<SPHisAction>();
        public List<SPModelEquip> SPModelEquipList { get; set; } = new List<SPModelEquip>();
        public List<SPModelSport> SPModelSportList { get; set; } = new List<SPModelSport>();

        public List<History> history { get; set; } = new List<History>();
        public List<History> histories { get; set; } = new List<History>();

        void ServiceState()
        {
            if (Callab != null)
                Callab.Invoke();
        }

        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public ServicesData(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            if (_navigationManager == null)
                _navigationManager = navigationManager;
        }


        private async Task SetUser(HttpResponseMessage use)
        {
            var response = await use.Content.ReadFromJsonAsync<List<SPClientUser>>();
            if (response != null)
                SPClientUserList  = response;
            ServiceState();
        }
        private async Task SetClass(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<SPClientClass>>();
            if (response != null)
                SPClientClassList = response;
            ServiceState();
        }
        private async Task SetDep(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<SPClientDep>>();
            if (response != null)
                SPClientDepList = response;
            ServiceState();
        }
        private async Task SetPos(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<SPClientPos>>();
            if (response != null)
                SPClientPosList = response;
            ServiceState();
        }
        private async Task SetPre(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<SPClientPre>>();
            if (response != null)
                SPClientPreList = response;
            ServiceState();
        }


        public async Task GetDbSPClientUser()
        {
            var result = await _http.GetFromJsonAsync<List<SPClientUser>>("api/Services/GetUsers");
            if (result != null)
                SPClientUserList = result;
        }
        public async Task GetDbSPClientProfile()
        {
            var result = await _http.GetFromJsonAsync<List<SPClientProfile>>("api/Services/GetProfile");
            if (result != null)
                SPClientProfileList = result;
        }
        public async Task GetDbSPClientClass()
        {
            var result = await _http.GetFromJsonAsync<List<SPClientClass>>("api/Services/GetClass");
            if (result != null)
                SPClientClassList = result;
        }
        public async Task GetDbSPClientDep()
        {
            var result = await _http.GetFromJsonAsync<List<SPClientDep>>("api/Services/GetDep");
            if (result != null)
                SPClientDepList = result;
        }
        public async Task GetDbSPClientPos()
        {
            var result = await _http.GetFromJsonAsync<List<SPClientPos>>("api/Services/GetPos");
            if (result != null)
                SPClientPosList = result;
        }
        public async Task GetDbSPClientPre()
        {
            var result = await _http.GetFromJsonAsync<List<SPClientPre>>("api/Services/GetPre");
            if (result != null)
                SPClientPreList = result;
        }



        public async Task CreateDbSPClientUser(SPClientUser user)
        {
            /*var result =*/ await _http.PostAsJsonAsync("api/Services/PostUser",user);
            /*await SetUser(result);*/
        }
        public async Task CreateDbSPClientClass(SPClientClass cla)
        {
            var result = await _http.PostAsJsonAsync("api/Services/PostClass", cla);
            await SetClass(result);
        }
        public async Task CreateDbSPClientDep(SPClientDep dep)
        {
            var result = await _http.PostAsJsonAsync("api/Services/PostDep", dep);
            await SetDep(result);
        }
        public async Task CreateDbSPClientPos(SPClientPos pos)
        {
            var result = await _http.PostAsJsonAsync("api/Services/PostPos", pos);
            await SetPos(result);
        }
        public async Task CreateDbSPClientPre(SPClientPre pre)
        {
            var result = await _http.PostAsJsonAsync("api/Services/PostPre", pre);
            await SetPre(result);
        }


        public async Task UpdateDbSPClientUser(SPClientUser user)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/PutUser?id={user.PHUserCode}", user);
            await SetUser(result);
        }
        public async Task UpdateDbSPClientClass(SPClientClass cla)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/PutClass", cla);
            await SetClass(result);
        }
        public async Task UpdateDbSPClientDep(SPClientDep dep)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/PutDep", dep);
            await SetDep(result);
        }
        public async Task UpdateDbSPClientPos(SPClientPos pos)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/PutPos?id={pos.PHPosCode}", pos);
            await SetPos(result);
        }
        public async Task UpdateDbSPClientPre(SPClientPre pre)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/PutPre", pre);
            await SetPre(result);
        }


        public async Task DeleteDbSPClientUser(string idu, string idp, SPClientUser pos)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/DelUser?idu={idu}&idp={idp}", pos);
            await SetUser(result);
        }
        public async Task DeleteDbSPClientClass(string id, SPClientClass pos)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/DelClass?id={id}", pos);
            await SetClass(result);
        }
        public async Task DeleteDbSPClientDep(string id, SPClientDep pos)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/DelDep?id={id}", pos);
            await SetDep(result);
        }
        public async Task DeleteDbSPClientPos(string id, SPClientPos pos)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/DelPos?id={id}",pos);
            await SetPos(result);
        }
        public async Task DeleteDbSPClientPre(string id, SPClientPre pos)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/DelPre?id={id}", pos);
            await SetPre(result);
        }

        public void ClearformUser()
        {
            SPClientUserX.PHProfileCode = string.Empty;
            SPClientUserX.PHUserCode = string.Empty;
            SPClientUserX.PHUserName = string.Empty;
            SPClientUserX.PHUserPassword = string.Empty;
            SPClientUserX.PHUserState = string.Empty;
            SPClientUserX.LSPClientProfile.PHProfilePhone = string.Empty;
            SPClientUserX.LSPClientProfile.PHClassCode = string.Empty;
            SPClientUserX.LSPClientProfile.PHDepCode = string.Empty;
            SPClientUserX.LSPClientProfile.PHPosCode = string.Empty;
            SPClientUserX.LSPClientProfile.PHPreCode = string.Empty;
            SPClientUserX.LSPClientProfile.PHProfileClassroom = string.Empty;
            SPClientUserX.LSPClientProfile.PHProfileEmail = string.Empty;
            SPClientUserX.LSPClientProfile.PHProfilefName = string.Empty;
            SPClientUserX.LSPClientProfile.PHProfilelName = string.Empty;
            SPClientUserX.LSPClientProfile.PHProfileIDcard = string.Empty;
            SPClientUserX.LSPClientProfile.PHProfileIDstudent = string.Empty;
            SPClientUserX.LSPClientProfile.PHProfileNameImg = string.Empty; 
            SPClientUserX.LSPClientProfile.PHProfileStorageImg = string.Empty; 
            ActionCall = "sign";
        }
        public void ClearformSport()
        {
            SPModelEquipX.PHEquipAmount = 0;
            SPModelEquipX.PHEquipCode = string.Empty;
            SPModelEquipX.PHEquipName = string.Empty;
            SPModelEquipX.PHSportCode = string.Empty;
            SPModelEquipX.PHEquipImg = string.Empty;
            SPModelEquipX.PHEquipUnit = string.Empty;
            SPModelEquipX.PHEquipStatus = string.Empty;
            ActionModel = "add";
        }

        public void EditMember(SPClientUser user)
        {
            var result = SPClientUserList.Where(x => x.PHUserCode == user.PHUserCode).ToList();
            SPClientUserX.PHUserCode = user.PHUserCode;
            SPClientUserX.PHProfileCode = user.PHProfileCode;
            SPClientUserX.PHUserName = user.PHUserName;
            SPClientUserX.PHUserPassword = user.PHUserPassword;
            SPClientUserX.PHUserState = user.PHUserState;
            SPClientUserX.LSPClientProfile.PHProfileCode=user.LSPClientProfile.PHProfileCode;
            SPClientUserX.LSPClientProfile.PHProfileIDcard=user.LSPClientProfile.PHProfileIDcard;
            SPClientUserX.LSPClientProfile.PHProfileIDstudent=user.LSPClientProfile.PHProfileIDstudent;
            SPClientUserX.LSPClientProfile.PHProfilePhone = user.LSPClientProfile.PHProfilePhone;
            SPClientUserX.LSPClientProfile.PHProfileEmail = user.LSPClientProfile.PHProfileEmail;
            SPClientUserX.LSPClientProfile.PHClassCode = user.LSPClientProfile.PHClassCode;
            SPClientUserX.LSPClientProfile.PHDepCode = user.LSPClientProfile.PHDepCode;
            SPClientUserX.LSPClientProfile.PHPosCode = user.LSPClientProfile.PHPosCode;
            SPClientUserX.LSPClientProfile.PHPreCode = user.LSPClientProfile.PHPreCode;
            SPClientUserX.LSPClientProfile.PHProfileClassroom=user.LSPClientProfile.PHProfileClassroom;
            SPClientUserX.LSPClientProfile.PHProfilefName=user.LSPClientProfile.PHProfilefName;
            SPClientUserX.LSPClientProfile.PHProfilelName=user.LSPClientProfile.PHProfilelName;
            SPClientUserX.LSPClientProfile.PHProfileNameImg = user.LSPClientProfile.PHProfileNameImg;
            SPClientUserX.LSPClientProfile.PHProfileStorageImg = user.LSPClientProfile.PHProfileStorageImg;
            ActionCall = "edite";
        }
        public void EditPos(SPClientPos pos)
        {
            var result = SPClientPosList.Where(x => x.PHPosCode == pos.PHPosCode).ToList();
            SPClientPosX.PHPosCode = pos.PHPosCode;
            SPClientPosX.PHPosName = pos.PHPosName;
            ActionPos = "two";
        }
        public void EditEquip(SPModelEquip equip)
        {
            var result = SPModelEquipList.Where(x => x.PHEquipCode == equip.PHEquipCode).ToList();
            SPModelEquipX.PHEquipCode = equip.PHEquipCode;
            SPModelEquipX.PHEquipBroken = equip.PHEquipBroken;
            SPModelEquipX.PHEquipLost = equip.PHEquipLost;
            SPModelEquipX.PHEquipAmount = equip.PHEquipAmount;
            SPModelEquipX.PHEquipName = equip.PHEquipName;
            SPModelEquipX.PHEquipImg = equip.PHEquipImg;
            SPModelEquipX.PHEquipUnit = equip.PHEquipUnit;
            SPModelEquipX.PHSportCode = equip.PHSportCode;
            ActionModel = "edite";
        }



        private async Task SetSport(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<SPModelSport>>();
            if (response != null)
                SPModelSportList = response;
            ServiceState();
        }
        private async Task SetEquip(HttpResponseMessage resE)
        {
            var response = await resE.Content.ReadFromJsonAsync<List<SPModelEquip>>();
            if (response != null)
                SPModelEquipList = response;
            ServiceState();
        }


        public async Task GetDbSPModelEquip()
        {
            var result = await _http.GetFromJsonAsync<List<SPModelEquip>>("api/Services/GetEquip");
            if (result != null)
                SPModelEquipList = result;
        }
        public async Task GetDbSPModelSport()
        {
            var result = await _http.GetFromJsonAsync<List<SPModelSport>>("api/Services/GetSport");
            if (result != null)
                SPModelSportList = result;
        }

        public async Task CreateDbSPModelEquip(SPModelEquip Equip)
        {
            await _http.PostAsJsonAsync("api/Services/PostEquip", Equip);
        }
        public async Task CreateDbSPModelSport(SPModelSport sport)
        {
            var result = await _http.PostAsJsonAsync("api/Services/PostSport", sport);
            await SetSport(result);
        }

        public async Task UpdateDbSPModelSport(SPModelSport sport)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/PutSport", sport);
            await SetSport(result);
        }
        public async Task UpdateDbSPModelEquip(SPModelEquip Equip)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/PutEquip?id={Equip.PHEquipCode}", Equip);
            await SetEquip(result);
        }
        public async Task BorrowDbSPModelEquip(SPModelEquip Equip)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/PutEquipTwo?id={Equip.PHEquipCode}", Equip);
            await SetEquip(result);
        }
        public async Task ReturnDbSPModelEquip(SPModelEquip Equip)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/PutEquipThree?id={Equip.PHEquipCode}", Equip);
            await SetEquip(result);
        }

        public async Task DeleteDbSPModelSport(string id, SPModelSport Equip)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/DelSport?id={id}", Equip);
            await SetSport(result);
        }
        public async Task DeleteDbSPModelEquip(string id, SPModelEquip Equip)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/DelEquip?id={id}", Equip);
            await SetEquip(result);
        }


        private async Task SetSPHisAction(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<SPHisAction>>();
            if (response != null)
                SPHisActionList = response;
            history = SPModelEquipList.Join(SPHisActionList,
            p => p.PHEquipCode,
            u => u.PHIDequip, (p, u) => new History
            {
                PHEquipImg = p.PHEquipImg,
                PHEquipName = p.PHEquipName,
                LSPModelSport = p.LSPModelSport,
                PHequipBorrow = u.PHequipBorrow,
                PHEquipUnit = p.PHEquipUnit,
                PHequipReturn = u.PHequipReturn,
                SPClientWhenBorrow = u.PHborrow,
                SPClientWhenReturn = u.PHreturn,
                PHHisActionCode = u.PHHisActionCode,
                PHEquipCode = u.PHIDequip,
                SPClientUsrCode = u.PHIDuser
            }).ToList();
            histories = history.Join(SPClientUserList,
                p => p.SPClientUsrCode,
                u => u.PHUserCode, (p, u) => new History
                {
                    PHHisActionCode = p.PHHisActionCode,
                    PHEquipImg = p.PHEquipImg,
                    PHEquipCode = p.PHEquipCode,
                    PHEquipUnit = p.PHEquipUnit,
                    PHEquipName = p.PHEquipName,
                    LSPModelSport = p.LSPModelSport,
                    PHequipBorrow = p.PHequipBorrow,
                    PHequipReturn = p.PHequipReturn,
                    SPClientWhenBorrow = p.SPClientWhenBorrow,
                    SPClientWhenReturn = p.SPClientWhenReturn,
                    SPClientUsrCode = p.SPClientUsrCode,
                    SPClientUsers = u,
                }).ToList();
            ServiceState();
        }
        public async Task GetDbSPHisAction()
        {
            var result = await _http.GetFromJsonAsync<List<SPHisAction>>("api/Services/GetHis");
            if (result != null)
                SPHisActionList = result;
            history = SPModelEquipList.Join(SPHisActionList,
            p => p.PHEquipCode,
            u => u.PHIDequip, (p, u) => new History
            {
                PHEquipImg = p.PHEquipImg,
                PHEquipName = p.PHEquipName,
                PHEquipUnit = p.PHEquipUnit,
                LSPModelSport = p.LSPModelSport,
                PHequipBorrow = u.PHequipBorrow,
                PHequipReturn = u.PHequipReturn,
                SPClientWhenBorrow = u.PHborrow,
                SPClientWhenReturn = u.PHreturn,
                PHHisActionCode = u.PHHisActionCode,
                PHEquipCode = u.PHIDequip,
                SPClientUsrCode = u.PHIDuser
            }).ToList();
            histories = history.Join(SPClientUserList,
                p => p.SPClientUsrCode,
                u => u.PHUserCode, (p, u) => new History
                {
                    PHHisActionCode = p.PHHisActionCode,
                    PHEquipImg = p.PHEquipImg,
                    PHEquipCode = p.PHEquipCode,
                    PHEquipName = p.PHEquipName,
                    PHEquipUnit = p.PHEquipUnit,
                    LSPModelSport = p.LSPModelSport,
                    PHequipBorrow = p.PHequipBorrow,
                    PHequipReturn = p.PHequipReturn,
                    SPClientWhenBorrow = p.SPClientWhenBorrow,
                    SPClientWhenReturn = p.SPClientWhenReturn,
                    SPClientUsrCode = p.SPClientUsrCode,
                    SPClientUsers = u,
                }).ToList();
            ServiceState();
        }
        public async Task CreateDbSPHisAction(SPHisAction His)
        {
            var res = await _http.PostAsJsonAsync("api/Services/PostHis", His);
            await SetSPHisAction(res);
        }
        public async Task TurnDbSPHisAction(SPHisAction His)
        {
            var result = await _http.PostAsJsonAsync($"api/Services/PutHis?id={His.PHHisActionCode}", His);
            await SetSPHisAction(result);
        }

    }
}
