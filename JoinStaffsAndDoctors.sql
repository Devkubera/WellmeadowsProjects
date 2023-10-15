SELECT      Staffs.ID, Staffs.staffID, Doctors.doctorID, Staffs.firstName, Staffs.lastName, Staffs.address, Staffs.tel, Staffs.dob, Staffs.nin, Staffs.position, Staffs.salary, Staffs.salaryScale, Staffs.hoursWeek, Staffs.contactType, Staffs.paidType
FROM          Staffs INNER JOIN
                      Doctors ON Staffs.staffID = Doctors.staffID