import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'CRM',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44323',
    redirectUri: baseUrl,
    clientId: 'CRM_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone CRM',
  },
  apis: {
    default: {
      url: 'https://localhost:44310',
      rootNamespace: 'CRM',
    },
  },
} as Environment;
