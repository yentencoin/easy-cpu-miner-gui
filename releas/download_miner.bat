rem Download cpuminer-opt-cpu-pool
rem https://eternallybored.org/misc/wget/
rem http://gnuwin32.sourceforge.net/packages/unzip.htm

REM download miner
wget.exe -nc https://github.com/cpu-pool/cpuminer-opt-cpupower/releases/download/1.4/Cpuminer-opt-cpu-pool-win64.zip

REM unzip miner
unzip.exe Cpuminer-opt-cpu-pool-win64.zip

REM move miner
md miner
move Cpuminer-opt-cpu-pool-win64\cpuminer-sse2.exe miner\cpuminer.exe
move Cpuminer-opt-cpu-pool-win64\libcrypto-1_1-x64.dll miner\
move Cpuminer-opt-cpu-pool-win64\libcurl-4.dll miner\
move Cpuminer-opt-cpu-pool-win64\libgcc_s_seh-1.dll miner\
move Cpuminer-opt-cpu-pool-win64\libstdc++-6.dll miner\
move Cpuminer-opt-cpu-pool-win64\libwinpthread-1.dll miner\
move Cpuminer-opt-cpu-pool-win64\zlib1.dll miner\
move Cpuminer-opt-cpu-pool-win64\libeay32.dll miner\
move Cpuminer-opt-cpu-pool-win64\libgmp-10.dll miner\
move Cpuminer-opt-cpu-pool-win64\libjansson-4.dll miner\

REM ----------------------
REM DOWNLOAD CPUMINER-OPT-CPU-POOL - OK
REM START Cpuminer-GUI.exe
REM ----------------------

pause