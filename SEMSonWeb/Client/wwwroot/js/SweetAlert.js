function SaveMemberjs() {
    return new Promise(resolve => {
        Swal.fire({
            icon: 'success',
            title: 'เพิ่มข้อมูลสำเร็จ',
            showConfirmButton: true,
            confirmButtomText: "ok",
        }).then((result) => {
            resolve(result.isConfirmed);
        })
    })
}
function UpdateMemberjs() {
    return new Promise(resolve => {
        Swal.fire({
            title: 'คุณต้องการบันทึกข้อมูลหรือไม่',
            icon: 'warning',
            showConfirmButton: true,
            showCancelButton: true,
            confirmButtonText: 'บันทึก',
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'ยกเลิก'
        }).then((result) => {
            if (result.isConfirmed) {
                Swal.fire(
                    'แก้ไขข้อมูลสำเร็จ!',
                    '',
                    'success'
                )
                resolve(result.isConfirmed);
            }
        })
    })
}
function DeleteMemberjs() {
    return new Promise(resolve => {
        Swal.fire({
            title: 'คุณต้องการลบข้อมูลหรือไม่',
            icon: 'warning',
            showConfirmButton: true,
            showCancelButton: true,
            confirmButtonText: 'ลบข้อมูล',
            confirmButtonColor: '#d33',
            cancelButtonText: 'ยกเลิก'
        }).then((result) => {
            if (result.isConfirmed) {
                Swal.fire(
                    'ลบข้อมูลสำเร็จ!',
                    '',
                    'success'
                )
                resolve(result.isConfirmed);
            }
        })
    })
}
function NotFoundAlert() {
    return new Promise(resolve => {
        Swal.fire({
            icon:'info',
            title:'ไม่พบข้อมูล',
            text:'รหัสไม่ถูกต้อง โปรดกรอกใหม่',
            confirmButtomText: "ok",
        }).then((result) => {
            if (result.isConfirmed) {
                resolve(result.isConfirmed);
            }
        })
    })
}function feildAlert() {
    return new Promise(resolve => {
        Swal.fire({
            icon:'info',
            title:'จำนวนไม่ถูกต้อง ',
            text:'กรุณากรอกจำนวนอุปกรณ์ที่ต้องการยืมใหม่',
            confirmButtomText: "ok",
        }).then((result) => {
            if (result.isConfirmed) {
                resolve(result.isConfirmed);
            }
        })
    })
}
function finishedBo() {
    return new Promise(resolve => {
        Swal.fire({
            icon: 'success',
            title: 'ยืมอุปกรณ์สำเร็จ',
            showConfirmButton: true,
            confirmButtomText: "ok",
        }).then((result) => {
            resolve(result.isConfirmed);
        })
    })
}
function TurnEQjs() {
    return new Promise(resolve => {
        Swal.fire({
            title: 'คุณต้องการคืนอุปกรณ์หรือไม่',
            icon: 'warning',
            showConfirmButton: true,
            showCancelButton: true,
            confirmButtonText: 'คืน',
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'ยกเลิก'
        }).then((result) => {
            if (result.isConfirmed) {
                Swal.fire(
                    'คืนอุปกรณ์กีฬาสำเร็จ!',
                    '',
                    'success'
                )
                resolve(result.isConfirmed);
            }
        })
    })
}