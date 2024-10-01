import os
import pytest


def test_key():
    assert os.getenv("MY_KEY") == "secret_key"
