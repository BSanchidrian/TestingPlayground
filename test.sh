#!/bin/bash

export DD_CIVISIBILITY_IMPACTED_TESTS_DETECTION_ENABLED=true
export DD_CIVISIBILITY_ENABLED=true
export DD_CIVISIBILITY_AGENTLESS_ENABLED=true
export DD_DOTNET_TRACER_HOME=$(pwd)/tracer-home
export DD_CIVISIBILITY_CODE_COVERAGE_COLLECTORPATH=$(pwd)/tracer-home
export DD_TRACE_DEBUG=true

export CORECLR_ENABLE_PROFILING=1
export CORECLR_PROFILER={846F5F1C-F9AE-4B07-969E-05C26BC060D8}
export CORECLR_PROFILER_PATH=$(pwd)/tracer-home/osx/Datadog.Trace.ClrProfiler.Native.dylib

export DD_SITE=datadoghq.eu
export DD_API_KEY=$1

dotnet test &
PID=$!
echo $PID

wait $PID

set -x && \
    cat /var/log/datadog/dotnet/dotnet-tracer-managed-dotnet-$PID.log | grep "Impacted"