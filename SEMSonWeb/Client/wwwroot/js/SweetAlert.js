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
function feildMoreAlert() {
    return new Promise(resolve => {
        Swal.fire({
            icon: 'info',
            title: 'จำนวนอุปกรณ์ไม่เพียงพอ',
            text: 'จำนวนที่ยืมมากกว่ายอดคงเหลือ กรุณากรอกใหม่',
            confirmButtomText: "ok",
        }).then((result) => {
            if (result.isConfirmed) {
                resolve(result.isConfirmed);
            }
        })
    })
}
function MoreTurnAlert() {
    return new Promise(resolve => {
        Swal.fire({
            icon: 'info',
            title: 'จำนวนอุปกรณ์ไม่สอดคล้อง',
            text: 'จำนวนที่อุปกรณ์ที่ชำรุด หรือสูญหายมากเกินไป กรุณากรอกใหม่',
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
            confirmButtonText: 'ยืนยัน',
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
function LoginFeild() {
    return new Promise(resolve => {
        Swal.fire({
            icon: 'warning',
            title: 'เข้าสู่ระบบไม่สำเร็จ',
            text: 'ชื่อบัญชีผู้ใช้งาน หรือรหัสผ่านไม่ถูกต้อง กรุณาลองใหม่อีกครั้ง',
            showClass: {
                popup: 'animate__animated animate__fadeInDown'
            },
            hideClass: {
                popup: 'animate__animated animate__fadeOutUp'
            }
        }).then((result) => {
            if (result.isConfirmed) {
                resolve(result.isConfirmed);
            }
        })
    })
}
function LoginSuccess() {
    return new Promise(resolve => {
        Swal.fire({
            //position: 'top-end',
            icon: 'success',
            title: 'เข้าสู่ระบบสำเร็จ',
            showConfirmButton: false,
            timer: 1500
        })
    })
}
function LogOutSuc() {
    return new Promise(resolve => {
        Swal.fire({
            title: 'คุณต้องการออกจากระบบรือไม่',
            icon: 'warning',
            showConfirmButton: true,
            showCancelButton: true,
            confirmButtonText: 'ยืนยัน',
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'ยกเลิก'
        }).then((result) => {
            if (result.isConfirmed) {
                Swal.fire(
                    'ออกจากระบบสำเร็จ',
                    '',
                    'success'
                )
                resolve(result.isConfirmed);
            }
        })
    })
}