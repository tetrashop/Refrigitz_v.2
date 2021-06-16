@echo off

call make clean
call mingw32-make profile-build ARCH=x86-64 COMP=mingw CXX=x86_64-w64-mingw32-g++ -j14
call strip sugar.exe
call ren sugar.exe sugar1.5-x86-64.exe

call make clean
call mingw32-make profile-build ARCH=x86-64-modern COMP=mingw CXX=x86_64-w64-mingw32-g++ -j14
call strip sugar.exe
call ren sugar.exe sugar1.5-x86-64-modern.exe

call make clean
call mingw32-make -f MakeFile build ARCH=x86-64-bmi2 COMP=mingw
call strip sugar.exe
call ren sugar.exe sugar1.5-x86-64-bmi2.exe

call make clean
call mingw32-make -f MakeFile profile-build ARCH=x86-32 COMP=mingw
call strip sugar.exe
call ren sugar.exe sugar1.5-x86-32.exe

call make clean
call mingw32-make -f MakeFile profile-build ARCH=x86-32-old COMP=mingw
call strip sugar.exe
call ren sugar.exe sugar1.5-x86-32-old.exe

call make clean
call mingw32-make -f MakeFile build ARCH=ppc-64 COMP=mingw
call strip sugar.exe
call ren sugar.exe sugar1.5-ppc-64.exe

call make clean
call mingw32-make -f MakeFile build ARCH=ppc-32 COMP=mingw
call strip sugar.exe
call ren sugar.exe sugar1.5-ppc-32.exe

call make clean
call mingw32-make -f MakeFile build ARCH=armv7 COMP=mingw
call strip sugar.exe
call ren sugar.exe sugar1.5-armv7.exe

call make clean
call mingw32-make -f MakeFile profile-build ARCH=general-64 COMP=mingw
call strip sugar.exe
call ren sugar.exe sugar1.5-general-64.exe

call make clean
call mingw32-make -f MakeFile profile-build ARCH=general-32 COMP=mingw
call strip sugar.exe
call ren sugar.exe sugar1.5-general-32.exe

call make clean
call pause
