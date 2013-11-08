defmodule Elixir.Mixfile do
  use Mix.Project

  def project do
    [ app: :elixir,
      version: "0.0.1",
      elixir: "~> 0.11.0",
      deps: deps ]
  end

  # Returns the list of dependencies in the format:
  # { :foobar, "~> 0.1", git: "https://github.com/elixir-lang/foobar.git" }
  defp deps do
    []
  end
end
