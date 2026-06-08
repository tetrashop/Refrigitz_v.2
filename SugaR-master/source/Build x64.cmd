@echo off

call make clean
call mingw32-make profile-build ARCH=x86-64 COMP=mingw CXX=x86_64-w64-mingw32-g++ -j14
call strip sugar.exe
call ren sugar.exe sugar1.5-x86-64.exe

call make clean
call pause
