{ pkgs, lib, config, inputs, ... }:

{
  languages.dotnet = {
    enable = true;
    package = pkgs.dotnet-sdk_8;
  };

  packages = [ ];
}
