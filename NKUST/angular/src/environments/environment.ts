import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'NKUST',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44391',
    redirectUri: baseUrl,
    clientId: 'NKUST_App',
    responseType: 'code',
    scope: 'offline_access NKUST',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44391',
      rootNamespace: 'NKUST',
    },
  },
} as Environment;
