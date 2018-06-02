# @copyright (c) 2017-2018 MSHP 32 team. All rights reserved.
""" MSHP 32 group final project """

package_info = 'MSHP PY Network remote interview system'

try:
    # Created by bump.py
    from .version import version_info
except Exception:
    # Bump it when you want change major and minor
    major, minor = (0, 1)
    version_info = major, minor     # type: ignore


team_email = "Team-32@informatics.ru"
author_info = (
    ('Mikhail Kaplenko', 'mvkaplenko@gmail.com'),
)

package_license = 'Apache'


__version__ = '.'.join(map(str, version_info))
__author__ = ', '.join('{} <{}>'.format(*info) for info in author_info)


__all__ = (
    '__author__',
    '__version__',
    'author_info',
    'package_license',
    'package_info',
    'team_email',
    'version_info',
)