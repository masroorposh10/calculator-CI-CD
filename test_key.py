from dotenv import load_dotenv  
import os
import pytest


load_dotenv()

def test_key():
    assert os.getenv("MY_KEY") == "secret_key"
