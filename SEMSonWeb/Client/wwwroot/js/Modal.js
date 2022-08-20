export function showModal(elementID) {
    if (elementID != null && elementID != undefined) {
        let modalElement = document.getElementById(elementID);
        modalElement.style.display = "block";
        return "ok";
    } else {
        return "error";
    }
}
export function HideModal(elementID) {
    if (elementID != null && elementID != undefined) {
        let modalElement = document.getElementById(elementID);
        modalElement.style.display = "none";
        return "ok";
    } else {
        return "error";
    }
}
/*function testAlt() {
    return new Promise(resolve => {
        Swal.fire({
            icon: 'success',
            title: 'เพิ่มข้อมูลสำเร็จ',
            showConfirmButton: true,
            *//*showCancelButton: true,*//*
            confirmButtomText: "ok",
            *//*cancelButtomText: "cancel"*//*
        }).then((result) => {
            resolve(result.isConfirmed);
        })
    })
}*/