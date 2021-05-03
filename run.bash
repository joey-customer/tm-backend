#!/bin/bash

export ASPNETCORE_URLS="http://*:${PORT}"
dotnet tm-backend.dll