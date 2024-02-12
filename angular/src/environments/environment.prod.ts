import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Chat',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44336/',
    redirectUri: baseUrl,
    clientId: 'Chat_App',
    responseType: 'code',
    scope: 'offline_access Chat',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44336',
      rootNamespace: 'Chat',
    },
  },
} as Environment;
