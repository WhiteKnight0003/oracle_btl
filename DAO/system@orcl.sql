create or replace PROCEDURE               SP_GetPowerfulAndID (
    p_username IN VARCHAR2,
    p_password IN VARCHAR2,
    p_id OUT VARCHAR2,
    p_powerful OUT VARCHAR2,
    p_name OUT VARCHAR2
)
AS
BEGIN
    SELECT  ID,POWERFUL, NAME
    INTO  p_id , p_powerful,p_name
    FROM NHOM01_ORACLE.LOGIN
    WHERE USERNAME = p_username AND PASSWORD = p_password;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        p_powerful := NULL;
        p_id := NULL;
        p_name := NULL;
END ;


create or replace PROCEDURE               SP_InsertStudent
(   
    p_id in VARCHAR2,
    p_name in VARCHAR2,
    p_Id_class in VARCHAR2,
    p_birthday in Date,
    p_Address in VARCHAR2,
    p_phone in VARCHAR2,
    p_email in VARCHAR2,
    p_sex in VARCHAR2,
    p_isActive in number
)
is
begin
    Insert into nhom01_oracle.students (ID, Name, Id_class,Birthday, address, phone, email, sex, isactive)
    values (p_id, p_name,p_id_class , p_birthday, p_Address , p_phone , p_email ,p_sex , p_isactive);
    commit;
end;


create or replace PROCEDURE               SP_InsertTeacher
(   
    p_id in VARCHAR2,
    p_name in VARCHAR2,
    p_birthday in Date,
    p_Address in VARCHAR2,
    p_phone in VARCHAR2,
    p_email in VARCHAR2,
    p_sex in VARCHAR2,
    p_isActive in number
)
is
begin
    Insert into nhom01_oracle.teachers (ID, Name, Birthday, address, phone, email, sex, isactive)
    values (p_id, p_name, p_birthday, p_Address , p_phone , p_email ,p_sex , p_isactive);
    commit;
end;



create or replace PROCEDURE                             SP_Login (
    p_username IN VARCHAR2,
    p_password IN VARCHAR2,
    p_result OUT NUMBER
)
AS
    v_count NUMBER;
BEGIN
    -- Ki?m tra username và password
    SELECT COUNT(*) INTO v_count 
    FROM nhom01_oracle.login 
    WHERE username = p_username AND password = p_password;

    -- ??t k?t qu?
    IF v_count > 0 THEN
        p_result := 1;  
    ELSE
        p_result := 0;  
    END IF;
END SP_Login;


create or replace PROCEDURE               SP_UpdateStudent
(   
   p_id IN VARCHAR2,
   p_name IN VARCHAR2,
   p_Id_class IN VARCHAR2, 
   p_birthday IN DATE,
   p_Address IN VARCHAR2,
   p_phone IN VARCHAR2,
   p_email IN VARCHAR2,
   p_sex IN VARCHAR2,
   p_isActive IN NUMBER
)
IS
BEGIN
   UPDATE nhom01_oracle.students 
   SET 
       Name = p_name,
       Id_class = p_Id_class,
       Birthday = p_birthday,
       address = p_Address,
       phone = p_phone,
       email = p_email,
       sex = p_sex,
       isactive = p_isActive
   WHERE ID = p_id;

   COMMIT;
END;


create or replace PROCEDURE                             SP_UpdateTeacher
(   
    p_id IN VARCHAR2,
    p_name IN VARCHAR2,
    p_birthday IN DATE,
    p_Address IN VARCHAR2,
    p_phone IN VARCHAR2,
    p_email IN VARCHAR2,
    p_sex IN VARCHAR2,
    p_isactive in number
)
IS
BEGIN
    UPDATE nhom01_oracle.teachers 
    SET Name = p_name,Birthday = p_birthday,address = p_Address,phone = p_phone,email = p_email,sex = p_sex , isactive = p_isactive
    WHERE ID = p_id;

    COMMIT;
END;
